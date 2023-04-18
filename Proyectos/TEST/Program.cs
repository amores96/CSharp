using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST {
  class Program {


    public static bool IsObsolete(Enum value) {
      Type enumType = value.GetType();
      string name = Enum.GetName(enumType, value);
      var fieldInfo = enumType.GetField(name);
      var obsoleteAttribute = (ObsoleteAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(ObsoleteAttribute), false);
      return (obsoleteAttribute != null);
    }


    public enum DefectsEnum {
      Light, 
      Medium, 
      [Obsolete]
      Dark, 
      Canker1,
      [Obsolete]
      Canker2, 
      Brown, 
      Crease,
      [Obsolete]
      Oleo,
      [Obsolete]
      Spectral1,
      [Obsolete]
      Spectral2,
      [Obsolete]
      Spectral3, 
      Damages, 
      UVDamages
    }


    public static Dictionary<DefectsEnum, string> DefectsNames = new Dictionary<DefectsEnum, string>() {
      {DefectsEnum.Light,"Light" },
      {DefectsEnum.Medium,"Medium"},
      {DefectsEnum.Dark,"Dark"},
      {DefectsEnum.Canker1,"Canker1"},
      {DefectsEnum.Canker2,"Canker2"},
      {DefectsEnum.Brown,"Brown"},
      {DefectsEnum.Crease,"Crease"},
      {DefectsEnum.Oleo,"Oleo"},
      {DefectsEnum.Spectral1,"Spectral1"},
      {DefectsEnum.Spectral2,"Spectral2"},
      {DefectsEnum.Spectral3,"Spectral3"},
      {DefectsEnum.Damages,"Damages"},
      {DefectsEnum.UVDamages,"UVDamages"},
    };


    public static List<string> defectsQLimitsVisualOrder = new List<string>() {
        DefectsNames[DefectsEnum.Light],
        DefectsNames[DefectsEnum.Medium],
        DefectsNames[DefectsEnum.Dark],
        DefectsNames[DefectsEnum.Canker1],
        DefectsNames[DefectsEnum.Canker2],
        DefectsNames[DefectsEnum.Brown],
        DefectsNames[DefectsEnum.Crease],
        DefectsNames[DefectsEnum.Oleo],
        DefectsNames[DefectsEnum.Spectral1],
        DefectsNames[DefectsEnum.Spectral2],
        DefectsNames[DefectsEnum.Spectral3],
        DefectsNames[DefectsEnum.Damages],
        DefectsNames[DefectsEnum.UVDamages]
    };


    public static int[] EliminarPosiciones(int[] _array, int[] _indices) {

      Array.Sort(_indices);

      for (int i = 0; i < _indices.Length; i++) {
        _indices[i] -= i;
      }

      foreach (var elemento in _indices) {
        int[] auxArray = new int[_array.Length - 1];
        if(elemento >= 0 && elemento < _array.Length) {
          Array.Copy(_array, 0, auxArray, 0, elemento);
          Array.Copy(_array, elemento + 1, auxArray, elemento, _array.Length - elemento - 1);
          _array = auxArray;
        } else {
          auxArray = _array;
        }
      }

      return _array;
    }


    static void Main(string[] args) {


      int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      int[] indexToDelete = { 1, 22 };


      int[] auxInt = EliminarPosiciones(array, indexToDelete);

      foreach (var elemento in auxInt) Console.Write(elemento);




      Console.ReadKey();

    }
  }
}
