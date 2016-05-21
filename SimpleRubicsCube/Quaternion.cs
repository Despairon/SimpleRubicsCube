using System.Collections.Generic;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using System;
using System.Windows.Forms;

namespace SimpleRubicsCube
{
    public class Quaternion
    {
        public Quaternion(double x, double y, double z, double degrees)
        {

            double angle = (degrees / 180.0f) * PI;
            double result = Math.Sin(angle / 2.0f);

            m_w = Math.Cos(angle / 2.0f);

            m_x = x * result;
            m_y = y * result;
            m_z = z * result;
        }

        public Quaternion(){}

        private double m_x;
        private double m_y;
        private double m_z;
        private double m_w;
        public const double PI = 3.1415926535897932384626433832795;

        public void createMatrix(ref double[] matrix)
        {
            matrix[0] = 1.0f - 2.0f * (m_y * m_y + m_z * m_z);
            matrix[1] = 2.0f * (m_x * m_y + m_z * m_w);
            matrix[2] = 2.0f * (m_x * m_z - m_y * m_w);
            matrix[3] = 0.0f;

            matrix[4] = 2.0f * (m_x * m_y - m_z * m_w);
            matrix[5] = 1.0f - 2.0f * (m_x * m_x + m_z * m_z);
            matrix[6] = 2.0f * (m_z * m_y + m_x * m_w);
            matrix[7] = 0.0f;

            matrix[8] = 2.0f * (m_x * m_z + m_y * m_w);
            matrix[9] = 2.0f * (m_y * m_z - m_x * m_w);
            matrix[10] = 1.0f - 2.0f * (m_x * m_x + m_y * m_y);
            matrix[11] = 0.0f;

            matrix[12] = 0;
            matrix[13] = 0;
            matrix[14] = 0;
            matrix[15] = 1.0f;
        }

        public static Quaternion operator*(Quaternion q, Quaternion r)
        {
            
            q.m_w = q.m_w * r.m_w - q.m_x * r.m_x - q.m_y * r.m_y - q.m_z * r.m_z;
            q.m_x = q.m_w * r.m_x + q.m_x * r.m_w + q.m_y * r.m_z - q.m_z * r.m_y;
            q.m_y = q.m_w * r.m_y + q.m_y * r.m_w + q.m_z * r.m_x - q.m_x * r.m_z;
            q.m_z = q.m_w * r.m_z + q.m_z * r.m_w + q.m_x * r.m_y - q.m_y * r.m_x;

            return r;
        }
    }
}
