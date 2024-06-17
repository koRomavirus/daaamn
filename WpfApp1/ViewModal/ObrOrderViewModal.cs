using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Data;
using WpfApp1.Entities;

namespace WpfApp1.ViewModal
{
    public class ObrOrderViewModal : ReactiveObject
    {
        private DateTime _dateAdd;
        private string _typeBreackdown;
        private string _desctiptionProblem;

        private ObservableCollection<Equipment> _equipment;


        private string _name;
        private string _description;
        private string _type;

        public DateTime DateAdd { get => _dateAdd; set => this.RaiseAndSetIfChanged(ref _dateAdd, value); }
        public string TypeBreackdown { get => _typeBreackdown; set => this.RaiseAndSetIfChanged(ref _typeBreackdown, value); }
        public string DescriptionProblem { get => _desctiptionProblem; set => this.RaiseAndSetIfChanged(ref _desctiptionProblem, value); }
        public ObservableCollection<Equipment> Equipment { get => _equipment; set => this.RaiseAndSetIfChanged(ref _equipment, value); }


        public string Name { get => _name; set => this.RaiseAndSetIfChanged( ref _name, value); }
        public string Description { get => _description; set => this.RaiseAndSetIfChanged(ref _description, value); }
        public string Type { get => _type; set => this.RaiseAndSetIfChanged(ref _type, value); }


        public ObrOrderViewModal()
        {
            List<Equipment> equipments = new List<Equipment>();
            using ( var context = new ApplicationDbContext())
            {
                equipments = context.Equipments.ToList();
            }
            Equipment = new ObservableCollection<Equipment>(equipments);
        }
        public ReactiveCommand<Object, Unit> EquipmentCreate => ReactiveCommand.Create<Object>(e =>
        {

            var equipment = new Equipment(Name, Description,Type);
            using (var context = new ApplicationDbContext())
            {
                context.Equipments.Add(equipment);
                context.SaveChanges();
            }
            Equipment.Add(equipment);
        });
    }
}
