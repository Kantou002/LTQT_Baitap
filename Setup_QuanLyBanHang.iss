; =====================================================
; Inno Setup Script - Quản Lý Bán Hàng v2.0
; Bài tập thực hành Buổi 10 - IMS501
; =====================================================

#define MyAppName "Quản Lý Bán Hàng"
#define MyAppVersion "2.0"
#define MyAppPublisher "Khoa Công nghệ thông tin - Trường ĐH An Giang"
#define MyAppURL "https://fit.agu.edu.vn"
#define MyAppExeName "QuanLyBanHang.exe"
#define MyOutputDir ".\Installer"

[Setup]
AppId={{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir={#MyOutputDir}
OutputBaseFilename=Setup_QuanLyBanHang_v2.0
SetupIconFile=QuanLyBanHang\SampleIcons\icon.ico
Compression=lzma2/ultra64
SolidCompression=yes
WizardStyle=modern
PrivilegesRequiredOverridesAllowed=dialog
; .NET 8 is required - user must install separately if missing
MinVersion=10.0

[Languages]
Name: "vietnamese"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "Tạo biểu tượng trên Desktop"; GroupDescription: "Biểu tượng bổ sung:"; Flags: unchecked
Name: "quicklaunchicon"; Description: "Tạo biểu tượng Quick Launch"; GroupDescription: "Biểu tượng bổ sung:"; Flags: unchecked; OnlyBelowVersion: 6.1

[Files]
; Main executable and all published output
Source: "QuanLyBanHang\bin\Release\net8.0-windows\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; Help files
Source: "QuanLyBanHang\Help\*"; DestDir: "{app}\Help"; Flags: ignoreversion recursesubdirs
; README
Source: "README.txt"; DestDir: "{app}"; Flags: ignoreversion isreadme

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\Hướng dẫn sử dụng"; Filename: "{app}\Help\HuongDanSuDung.html"
Name: "{group}\Gỡ cài đặt {#MyAppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Khởi động {#MyAppName}"; Flags: nowait postinstall skipifsilent

[Code]
// Kiểm tra .NET 8 đã được cài chưa
function IsDotNet8Installed: Boolean;
var
  ResultCode: Integer;
begin
  Result := ShellExec('', 'dotnet', '--version', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if not IsDotNet8Installed then
  begin
    if MsgBox('.NET 8.0 Runtime chưa được cài đặt.' + #13#10 +
              'Vui lòng tải và cài đặt .NET 8.0 Windows Desktop Runtime từ:' + #13#10 +
              'https://dotnet.microsoft.com/download/dotnet/8.0' + #13#10#13#10 +
              'Bạn có muốn tiếp tục cài đặt không?',
              mbConfirmation, MB_YESNO) = IDNO then
      Result := False;
  end;
end;
