using System.ComponentModel;

namespace MySqlWithEntityFramework.EF.Models;
public class Laptop {
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    [DisplayName("Company Name")]
    public string CompanyName { get; set; } = string.Empty;
    [DisplayName("Model Number")]
    public string ModelNumber { get; set; } = string.Empty;
    [DisplayName("Serial Number")]
    public string SerialNumber { get; set; } = string.Empty;
}
