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
</Query>

//Country country = new Country(){
//	Name = "United States Of America",
//	ShortName = "USA",
//	Code = "US",
//	CreatedBy = "ricardo.net.developer@hotmail.com",
//	CreatedOn = DateTime.Now,
//	ChangedBy = "ricardo.net.developer@hotmail.com",
//	ChangedOn = DateTime.Now,
//	IsActive = true,
//	IsDeleted = false	
//};
//this.Country.Add(country);
////this.SaveChanges();