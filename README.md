# NugetCiAppveyor

# AppVeyor CI ile NuGet Paketi Yayınlama 🚀

Bu repo, AppVeyor Continuous Integration (CI) kullanarak NuGet paketlerini otomatik olarak nasıl yayınlayabileceğinizi gösterir. .NET projelerinizde NuGet paketlerini yayınlamak için gerekli yapılandırma ve dağıtım süreçlerini adım adım öğrenebilirsiniz.

## Özellikler

- **AppVeyor Yapılandırması**: AppVeyor CI'yi projeleriniz için nasıl yapılandırabileceğinizi öğrenin.
- **NuGet Paketi Yayınlama**: GitHub deposundan doğrudan NuGet paketlerinizi otomatik olarak nasıl yayınlayabileceğinizi keşfedin.
- **CI/CD Pipeline**: .NET projeleriniz için eksiksiz bir CI/CD pipeline'ı oluşturma adımlarını anlayın.

## Başlarken

Bu projeyi kendi makinenizde çalıştırmak için aşağıdaki adımları izleyin.

### Gereksinimler

- .NET 6.0 veya daha yeni bir sürüm
- AppVeyor hesabı
- NuGet API Key

### Kurulum

1. Bu projeyi klonlayın:
    ```sh
    git clone https://github.com/yilmazolmez/Nuget-CiAppveyor.git
    cd proje-adi
    ```

2. AppVeyor CI'yi yapılandırın:
    - `.appveyor.yml` dosyasını güncelleyin.
    - Proje ayarlarından NuGet API anahtarınızı ekleyin.

3. Commit ve push yaparak AppVeyor'da CI/CD pipeline'ını başlatın:
    ```sh
    git add .
    git commit -m "AppVeyor ile CI/CD yapılandırıldı"
    git push origin main
    ```

### Kullanım

AppVeyor CI, her commit sonrası otomatik olarak NuGet paketlerinizi yayınlayacaktır.

