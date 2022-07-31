using Common;

AppSettingsValidator appSettingsValidator = new AppSettingsValidator();
ConfigValidator configValidator = new ConfigValidator();
ConfigReader configReader = new ConfigReader();
Walker w = new Walker();
w.Traverse(".", (fi) => 
{ 
    
    if (configValidator.IsValid(fi)) 
    {
        Console.WriteLine("Config: {0}", fi.FullName); 
        configReader.Parse(fi);

    } else if (appSettingsValidator.IsValid(fi)) 
    {
        Console.WriteLine("AppSettings: {0}", fi.FullName); 
    }
    
    return true;
});
