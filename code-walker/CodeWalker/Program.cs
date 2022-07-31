using Common;

AppSettingsValidator appSettingsValidator = new AppSettingsValidator();
ConfigValidator configValidator = new ConfigValidator();
Walker w = new Walker();
w.Traverse(".", (fi) => 
{ 
    
    if (configValidator.IsValid(fi)) 
    {
        Console.WriteLine("Config: {0}", fi.FullName); 
    } else if (appSettingsValidator.IsValid(fi)) 
    {
        Console.WriteLine("AppSettings: {0}", fi.FullName); 
    }
    
    return true;
});
