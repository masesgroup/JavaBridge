#
# Module manifest for module 'MASES.JNetPS'
#
# Generated by: MASES s.r.l.
#

@{

# Script module or binary module file associated with this manifest
ModuleToProcess = 'MASES.JNetPS.dll'

# Version number of this module.
ModuleVersion = '2.5.7'

# ID used to uniquely identify this module
GUID = 'AD7117B7-AC1A-4769-80FC-BF63A11D2B92'

# Author of this module
Author = 'MASES s.r.l.'

# Company or vendor of this module
CompanyName = 'MASES s.r.l.'

# Copyright statement for this module
Copyright = 'Copyright ©  MASES s.r.l. 2024'

# Description of the functionality provided by this module
Description = 'PowerShell Module to use JVM and PowerShell side-by-side. With JNetPS it is possible to use JVM objects within PowerShell. See https://github.com/masesgroup/JNet for further information.'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Specifies the compatible PSEditions of the module.
CompatiblePSEditions = @('Desktop')

# Name of the Windows PowerShell host required by this module
PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
PowerShellHostVersion = ''

# Minimum version of the .NET Framework required by this module
DotNetFrameworkVersion = '4.6.2'

# Minimum version of the common language runtime (CLR) required by this module
CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64, IA64) required by this module
ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module
ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
#FormatsToProcess = ''

# Modules to import as nested modules of the module specified in ModuleToProcess
NestedModules= @()

# Functions to export from this module
FunctionsToExport = @()

# Cmdlets to export from this module
CmdletsToExport = @(
    'Start-JNetPS',
    'Invoke-JCommand',
    'New-JObject',
    'Get-ClassForName',
    'Add-NotificationListener',
    'Get-DefaultDomain',
    'Get-Domains',
    'Get-IsMXBeanInterface',
    'Get-JMXConnector',
    'Get-MBeanCount',
    'Get-MBeanInfo',
    'Get-QueryNames',
    'Get-QueryClassattr',
    'Get-QueryValueExp',
    'Invoke-QueryAnd'
    'Invoke-QueryAnySubString',
    'Invoke-QueryAttr',
    'Invoke-QueryBetween',
    'Invoke-QueryDiv',
    'Invoke-QueryEq',
    'Invoke-QueryFinalSubString',
    'Invoke-QueryGeq',
    'Invoke-QueryGt',
    'Invoke-QueryIn',
    'Invoke-QueryInitialSubString',
    'Invoke-QueryIsInstanceOf',
    'Invoke-QueryLeq',
    'Invoke-QueryLt',
    'Invoke-QueryMatch',
    'Invoke-QueryMinus',
    'Invoke-QueryNot',
    'Invoke-QueryOr',
    'Invoke-QueryPlus',
    'Invoke-QueryTimes',
    'New-AttributeChangeNotificationFilter',
    'New-JMXServiceURL',
    'New-MBeanProxy',
    'New-MXBeanProxy',
    'New-NotificationFilterSupport',
    'New-NotificationListener',
    'New-ObjectName',
    'Remove-NotificationListener'
)

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module
AliasesToExport = @()

# List of all modules packaged with this module
ModuleList = @()

# List of all files packaged with this module
FileList = ''

# Private data to pass to the module specified in ModuleToProcess
PrivateData = @{

    PSData = @{

        Tags = @('JNetPS', 'JNet', 'PSEdition_Core', 'PSEdition_Desktop', 'Windows', 'Linux', 'JVM', 'Java', 'Scala', 'Kotlin', 'bridge', 'gateway')

        LicenseUri = 'https://github.com/masesgroup/JNet/blob/master/LICENSE'

        ProjectUri = 'https://github.com/masesgroup/JNet'

        IconUri = 'https://raw.githubusercontent.com/masesgroup/JNet/master/src/net/Common/JCOB128x128.png'

        ReleaseNotes = 'https://github.com/masesgroup/JNet/releases'

    }
}

HelpInfoURI = 'https://jnet.masesgroup.com/articles/usagePS.html'

# DefaultCommandPrefix = ''
}