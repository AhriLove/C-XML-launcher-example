<?php

/***********************************************
* Configuration                                *
***********************************************/

// MySQL configuration
$dbHost = "127.0.0.1";
$dbPort = "3306";
$dbUser = "root";
$dbPass = "";

// Databases name
$webDb = "web";
$charactersDb = "characters";

// Game server
$serverHost = "127.0.0.1";
$serverPort = "8085";

/***********************************************
* Connect to MySQL                             *
***********************************************/
$conn = mysql_connect($dbHost . ":" . $dbPort, $dbUser, $dbPass);

if (!$conn)
    die("Failed to connect to MySQL server, check your configuration in the top of this file.");

/***********************************************
* Generate output                              *
***********************************************/
$xml = new SimpleXMLElement("<?xml version=\"1.0\" encoding=\"utf-8\" ?><ServerInfo></ServerInfo>");

// Generate news output
$news = $xml->addChild('News');

//// Get articles from database and write to xml
mysql_select_db($webDb, $conn);
$query = mysql_query("SELECT * FROM `news` ORDER BY `id` DESC LIMIT 0,5", $conn);

while ($row = mysql_fetch_assoc($query))
{
    $article = $news->addChild('article');
    $article->addChild('id', $row['id']);
    $article->addChild('title', $row['title']);
    $article->addChild('date', $row['date']);
    $article->addChild('summary', $row['summary']);
}

mysql_free_result($query);

// Generate server status info
$status = $xml->addChild('ServerStatus');

// Check and print server status
$serverStatus = @fsockopen($serverHost, $serverPort, $errno, $errstr, 1.5) ? "Online" : "Offline";
$status->addChild('status', $serverStatus);

// Get and players online info
$alliance_races = array(1, 3, 4, 11, 7, 22);
$horde_races = array(2, 5, 6, 8, 10, 9);

mysql_select_db($charactersDb, $conn);
$query = mysql_query("SELECT `race` FROM `characters` WHERE `online` = 1", $conn);
$totalPlayers = mysql_num_rows($query);

$alliancesOnline = 0;
$hordesOnline = 0;

// Get alliance / horde count
while ($char = mysql_fetch_assoc($query))
{
    if (in_array($char['race'], $alliance_races))
        $alliancesOnline++;
    else
        $hordesOnline++;
}

// Print counts
$status->addChild('playersOnline', $totalPlayers);
$status->addChild('allianceOnline', $alliancesOnline);
$status->addChild('hordeOnline', $hordesOnline);

Header('Content-type: text/xml');
print($xml->asXML());
