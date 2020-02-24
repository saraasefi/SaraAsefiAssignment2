using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaraAsefiAssignment2
{
    public static class TriangleSolver
    {
        public static string  Analyze(int dim1, int dim2, int dim3)
        {
            string result = "";

            if((dim1 + dim2 > dim3) && (dim1 + dim3 > dim2) && (dim2 + dim3 > dim1))
            {
                if(dim1 == dim2 && dim1 == dim3)
                {
                    result = "Equilateral Triangle!";
                }
                else if(dim1 == dim2 || dim1 == dim3 || dim2 == dim3)
                {
                    result = "Isosceles Triangle!";
                }
                else
                {
                    result = "Scalene Triangle!";
                }
            }
            else
            {
                result = "Not a triangle!";
            }
            return result;
        }
    }
}
