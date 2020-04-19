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

EfRepository<StateProvince> _repo =
	new EfRepository<StateProvince>(new CountryCatalogDbContext());
	
StateProvinceWithCountrySpecification spec = new StateProvinceWithCountrySpecification(10001);	

_repo.ListAsync(spec).Dump();

