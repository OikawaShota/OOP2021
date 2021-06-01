using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    //インチとメートルの単位変換クラス
    public static class InchConverter {//staticのメソッドしかないから、クラス自体をstaticにする。→別クラスでインスタンスを生成(new)できなくなる
        private const double ratio = 0.0254;
        //メートルからインチを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //インチからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
