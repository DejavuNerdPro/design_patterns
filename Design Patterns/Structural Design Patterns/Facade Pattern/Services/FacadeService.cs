

namespace Design_Patterns.Structural_Design_Patterns.Facade_Pattern.Services
{
    public class FacadeService
    {
        private readonly PaymentService _paymentService = new();
        private readonly InventoryService _inventoryService = new();
        private readonly TechnologyService _technologyService = new();

        public void Payment() => _paymentService.Pay();
        public void Inventory() => _inventoryService.brand();
        public void Technology() => _technologyService.tech();
    }
}
