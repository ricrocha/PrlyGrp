<Query Kind="Statements">
  <Connection>
    <ID>66febac6-be48-4778-82ff-aecebc3eb619</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPath>C:\VS\pGroup\PrlyGrp\src\Services\CountryCatalog\PrlyGrp.CountryCatalog.Infrastructure\bin\Debug\netstandard2.1\PrlyGrp.CountryCatalog.Infrastructure.dll</CustomAssemblyPath>
    <CustomTypeName>PrlyGrp.CountryCatalog.Infrastructure.Data.CountryCatalogDbContext</CustomTypeName>
    <CustomCxString>Data Source=.;Integrated Security=SSPI;Initial Catalog=CountryCatalogDbDev;app=LINQPad</CustomCxString>
    <DisplayName>CountryCatalogDbContextDll</DisplayName>
    <DriverData>
      <UseDbContextOptions>true</UseDbContextOptions>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
  <Output>DataGrids</Output>
  <Namespace>PrlyGrp.CountryCatalog.ApplicationCore.Entities</Namespace>
  <Namespace>PrlyGrp.CountryCatalog.ApplicationCore.Specifications</Namespace>
</Query>

EfRepository<Country> _repo = 
	new EfRepository<Country>(new CountryCatalogDbContext());
	
CountryWithStateProvincesSpecification spec = new CountryWithStateProvincesSpecification(10001);
	
//var countries = _repo.ListAllAsync();
var countries10001 = _repo.ListAsync(spec);

//countries.Dump();
countries10001.Dump();