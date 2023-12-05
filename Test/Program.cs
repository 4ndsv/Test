// See https://aka.ms/new-console-template for more information
using Test.Models;

Console.WriteLine("Creating institutions...");
var institution = new FinancialInstitution("Bank One");

Console.WriteLine("Creating financial instruments");
var instrument1 = new FinancialInstrument("Stock", 800000);
var instrument2 = new FinancialInstrument("Bond", 1500000);
var instrument3 = new FinancialInstrument("Derivative", 6000000);
var instrument4 = new FinancialInstrument("Stock", 300000);

Console.WriteLine("Creating portifolio");
var portfolio = new Portfolio("Portfolio One");
portfolio.FinancialInstruments = new List<FinancialInstrument>
{
    instrument1,
    instrument2,
    instrument3,
    instrument4
};

institution.Portfolios = new List<Portfolio>() { portfolio };
Console.WriteLine("Instruments: ");
foreach (var item in institution.Portfolios[0].FinancialInstruments)
{
    Console.WriteLine(item.Type + " - " + item.MarketValue);
};
Console.WriteLine("Instrument Categories: " + String.Join(", ", institution.Portfolios[0].InstrumentCategories));

Console.ReadLine();


