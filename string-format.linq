<Query Kind="Statements" />

var s = String.Format("New message arrived, size {0:#,##0.00}KB. Total received size {1,5:#,##0.00}MB", 999.00, 888.888);
 s.Dump();


var p = 1000001.8888;
$"After last DLIS file change, waiting {p:0.00} hours".Dump();
$"After last DLIS file change, waiting {p:#,##0.00} hours".Dump();
