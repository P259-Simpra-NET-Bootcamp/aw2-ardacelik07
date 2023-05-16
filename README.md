
# Core layer
 bu katmanda baseModels adlı bir dosyamın icin de base modelimi tuttuğum bir class vardır.
 Id,CreatedAt,CreatedBy olan 3 alandan oluşmaktadır ve aynı zaman da yapıcı metodumla createdAt ve CreatedBy ın değerlerini atıyorum.
# DataLayer
Bu katmanda Configuration adlı bir klasör ve interface içinde IConfiguration adlı bir klasörüm mevcut Configurationın için de UnitOfWork Iconfiguration nın içinde de unitofwork ün interfaceni bulunduruyor.
Context klasöründe database context classım var.
Migration klasörüm de migration dosyalarım bulunmaktadır.
Models klasöründe entitylerim bulunmakta bu ödev kapsamında staff adlı model istendiği için staff modelim bulunmaktadır.Staff modeli basemodel den miras almaktadır.
Repository klosörümün içinde ayrıyetten iki tane daha klasör vardır. IRepositories ve Repositories olarak Irepo içersinde IGenericRepositoru Repo klasörümün içersinde ise GenericRepository bulunmaktadır.
# SimOdevApi
Bu katmanda controllerlarrım bulunmaktadır. (StaffController)
dto klasörümde Dosyalı Transfer Otomasyonlarım bulunmaktadır. filtrelemei FirstName ve City ye göre yaptıgım için FilterParams da bu iki property bulunmaktadır.ekstra olarak StaffRequestDto ve UserUpdateDto bulunmaktadır.
FluentValidation klasörümde Fluent validation kütüphanesini kullanarak validation kontrollerini yaptıgım staffrequestValidator ve StaffUpdateValidator classlarım bulunmaktadır.
RestExtension klasörümde ise extension classlarım bulunuyor.

