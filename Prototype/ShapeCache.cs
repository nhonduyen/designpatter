using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Prototype
{
    class ShapeCache
    {
        public static Dictionary<int, Shape> shapeMap = new Dictionary<int, Shape>();

        public static Shape getShape(int id)
        {
            Shape cachedShape;
            if (!shapeMap.TryGetValue(id, out cachedShape))
                return null;
            return (Shape)cachedShape.Clone();
        }

        public static void loadCache()
        {
            DataTable shapes = mgrDataSQL.ExecuteStoreReader("GET_ALL_SHAPE");
            for (int i = 0; i < shapes.Rows.Count; i++ )
            {
                string type = shapes.Rows[i]["type"].ToString().Trim().ToLower();

                switch (type)
                {
                    case "rectangle":
                        Rectangle rec = new Rectangle();
                        rec.setId(Convert.ToInt32(shapes.Rows[i]["id"]));
                        shapeMap.Add(rec.getId(), rec);
                        break;
                    case "circle":
                        Circle cir = new Circle();
                        cir.setId(Convert.ToInt32(shapes.Rows[i]["id"]));
                        shapeMap.Add(cir.getId(), cir);
                        break;
                    case "square":
                        Square square = new Square();
                        square.setId(Convert.ToInt32(shapes.Rows[i]["id"]));
                        shapeMap.Add(square.getId(), square);
                        break;
                }

            }
        }
    }
}
