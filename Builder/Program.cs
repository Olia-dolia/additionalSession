using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class TableLamp
    {
        private bool _lampState;
        public string bearing { get; set; }
        public string lampshade { get; set; }
        public string lamp { get; set; }
        public string cabel { get; set; }
        public string lampSwitch { get; set; }
        public bool state { get { return _lampState; } }
        public void SetState(bool state)
        {
            _lampState = state;
        }
    }
        abstract class TableLampBuilder
        {
            protected TableLamp _tLamp;
            public TableLamp GetTableLamp()
            {
                return _tLamp;
            }
            public void CreateNewTableLamp()
            {
                _tLamp = new TableLamp();
            }
            public abstract void BuildHask();
            public abstract void FinallyBuild();
        }

    class ToOrderTableLampBuilder : TableLampBuilder
    {
        public override void BuildHask()
        {
            _tLamp.lamp = "Лампочка енергозбереження";
            _tLamp.bearing = "Вертикальний опір";
            _tLamp.cabel = "Бездротова";
            _tLamp.lampSwitch = "Сенсорний вимикач";
            _tLamp.SetState(false);
        }
        public override void FinallyBuild()
        {
            _tLamp.lampshade = "Чорний плафон";
        }
    }
    class Worker
    {
        private TableLampBuilder builder;
        public void SetTableLampBuilder()
        {
            this.builder = new ToOrderTableLampBuilder();
        }
        public TableLamp GetTableLamp()
        {
            return builder.GetTableLamp();
        }
        public void BuildTableLamp()
        {
            builder.CreateNewTableLamp();
            builder.BuildHask();
            builder.FinallyBuild();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker d = new Worker();
            d.SetTableLampBuilder();
            d.BuildTableLamp();
            TableLamp tableLamp = d.GetTableLamp();
        }
    }
}
