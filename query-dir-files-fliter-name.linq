<Query Kind="Statements" />

var dlisFilePath = Directory.GetFiles("D:\\dlis2blob").Where(x => x.ToLower().Contains(".dlis"));

dlisFilePath.Dump();
