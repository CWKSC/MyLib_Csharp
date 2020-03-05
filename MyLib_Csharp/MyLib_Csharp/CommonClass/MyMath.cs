﻿using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyMath
    {

        #region Static constant 

        #region PI
        public const double TwoPI = 2 * Math.PI;
        public const double PIOver2 = Math.PI / 2;
        public const double PIOver4 = Math.PI / 4;
        public const double PIOver8 = Math.PI / 8;
        public const double PIOver16 = Math.PI / 16;
        public const double PIOver32 = Math.PI / 32;
        public const double PIOver64 = Math.PI / 64;
        #endregion

        #region Angle convert constant
        public const double DegToRad = Math.PI / 180;
        public const double DegToGrad = 10 / 9;
        public const double DegToTurn = 1 / 360;

        public const double RadToDeg = 180 / Math.PI;
        public const double RadToGrad = 200 / Math.PI;
        public const double RadToTurn = 1 / (2 * Math.PI);

        public const double GradToDeg = 9 / 10;
        public const double GradToRad = Math.PI / 200;
        public const double GradToTurn = 1 / 400;

        public const double TurnToDeg = 360;
        public const double TurnToRad = 2 * Math.PI;
        public const double TurnToGrad = 400;

        public const double RightAngleDeg = TurnToDeg / 4;
        public const double RightAngleRad = TurnToRad / 4;
        public const double RightAngleGrad = TurnToGrad / 4;
        public const double RightAngleTurn = 1 / 4;

        public const double HalfTurnDeg = TurnToDeg / 2;
        public const double HalfTurnRad = TurnToRad / 2;
        public const double HalfTurngGrad = TurnToGrad / 2;
        public const double HalfTurn = 1 / 2;
        #endregion

        #region Square of root
        public const float squareRoot2_float = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157f;
        public const float squareRoot3_float = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154f;
        public const float squareRoot5_float = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227f;
        public const float squareRoot6_float = 2.44948974278317809819728407470589139196594748065667f;
        public const float squareRoot7_float = 2.64575131106459059050161575363926042571025918308245f;
        public const float squareRoot8_float = 2.82842712474619009760337744841939615713934375075389f;
        public const float squareRoot10_float = 3.16227766016837933199889354443271853371955513932521f;

        public const double squareRoot2_double = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157;
        public const double squareRoot3_double = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154;
        public const double squareRoot5_double = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227;
        public const double squareRoot6_double = 2.44948974278317809819728407470589139196594748065667;
        public const double squareRoot7_double = 2.64575131106459059050161575363926042571025918308245;
        public const double squareRoot8_double = 2.82842712474619009760337744841939615713934375075389;
        public const double squareRoot10_double = 3.16227766016837933199889354443271853371955513932521;

        public const decimal squareRoot2_decimal = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157M;
        public const decimal squareRoot3_decimal = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154M;
        public const decimal squareRoot5_decimal = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227M;
        public const decimal squareRoot6_decimal = 2.44948974278317809819728407470589139196594748065667M;
        public const decimal squareRoot7_decimal = 2.64575131106459059050161575363926042571025918308245M;
        public const decimal squareRoot8_decimal = 2.82842712474619009760337744841939615713934375075389M;
        public const decimal squareRoot10_decimal = 3.16227766016837933199889354443271853371955513932521M;
        #endregion

        #endregion


        #region Cartesian to Polar
        public static double CartesianToPolar_Radians(double x, double y) => Math.Atan2(y, x);
        public static double CartesianToPolar_Radians(Vector2 point) => Math.Atan2(point.Y, point.X);
        public static double CartesianToPolar_Degrees(double x, double y) => Math.Atan2(y, x) * RadToDeg;
        public static double CartesianToPolar_Degrees(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToDeg;
        public static double CartesianToPolar_Gradians(double x, double y) => Math.Atan2(y, x) * RadToGrad;
        public static double CartesianToPolar_Gradians(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad;
        public static double CartesianToPolar_Turns(double x, double y) => Math.Atan2(y, x) * RadToTurn;
        public static double CartesianToPolar_Turns(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToTurn;

        #region Cartesian to Polar (start at Up)
        public static double CartesianToPolar_startAtUp_Radians(double x, double y) => Math.Atan2(y, x) - RightAngleRad;
        public static double CartesianToPolar_startAtUp_Radians(Vector2 point) => Math.Atan2(point.Y, point.X) - RightAngleRad;
        public static double CartesianToPolar_startAtUp_Degrees(double x, double y) => Math.Atan2(y, x) * RadToDeg - RightAngleDeg;
        public static double CartesianToPolar_startAtUp_Degrees(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToDeg - RightAngleDeg;
        public static double CartesianToPolar_startAtUp_Gradians(double x, double y) => Math.Atan2(y, x) * RadToGrad - RightAngleGrad;
        public static double CartesianToPolar_startAtUp_Gradians(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - RightAngleGrad;
        public static double CartesianToPolar_startAtUp_Turns(double x, double y) => Math.Atan2(y, x) * RadToGrad - RightAngleTurn;
        public static double CartesianToPolar_startAtUp_Turns(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - RightAngleTurn;
        #endregion

        #region Cartesian to Polar (start at Left)
        public static double CartesianToPolar_startAtLeft_Radians(double x, double y) => Math.Atan2(y, x) - 2 * RightAngleRad;
        public static double CartesianToPolar_startAtLeft_Radians(Vector2 point) => Math.Atan2(point.Y, point.X) - 2 * RightAngleRad;
        public static double CartesianToPolar_startAtLeft_Degrees(double x, double y) => Math.Atan2(y, x) * RadToDeg - 2 * RightAngleDeg;
        public static double CartesianToPolar_startAtLeft_Degrees(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToDeg - 2 * RightAngleDeg;
        public static double CartesianToPolar_startAtLeft_Gradians(double x, double y) => Math.Atan2(y, x) * RadToGrad - 2 * RightAngleGrad;
        public static double CartesianToPolar_startAtLeft_Gradians(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - 2 * RightAngleGrad;
        public static double CartesianToPolar_startAtLeft_Turns(double x, double y) => Math.Atan2(y, x) * RadToGrad - 2 * RightAngleTurn;
        public static double CartesianToPolar_startAtLeft_Turns(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - 2 * RightAngleTurn;
        #endregion

        #region Cartesian to Polar (start at Down)
        public static double CartesianToPolar_startAtDown_Radians(double x, double y) => Math.Atan2(y, x) - 3 * RightAngleRad;
        public static double CartesianToPolar_startAtDown_Radians(Vector2 point) => Math.Atan2(point.Y, point.X) - 3 * RightAngleRad;
        public static double CartesianToPolar_startAtDown_Degrees(double x, double y) => Math.Atan2(y, x) * RadToDeg - 3 * RightAngleDeg;
        public static double CartesianToPolar_startAtDown_Degrees(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToDeg - 3 * RightAngleDeg;
        public static double CartesianToPolar_startAtDown_Gradians(double x, double y) => Math.Atan2(y, x) * RadToGrad - 3 * RightAngleGrad;
        public static double CartesianToPolar_startAtDown_Gradians(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - 3 * RightAngleGrad;
        public static double CartesianToPolar_startAtDown_Turns(double x, double y) => Math.Atan2(y, x) * RadToGrad - 3 * RightAngleTurn;
        public static double CartesianToPolar_startAtDown_Turns(Vector2 point) => Math.Atan2(point.Y, point.X) * RadToGrad - 3 * RightAngleTurn;
        #endregion

        #endregion


        #region Degrees convert
        public static double DegreesToRadians(double degrees) => degrees * DegToRad;
        public static double DegreesToGradians(double degrees) => degrees * DegToGrad;
        public static double DegreesToTurns(double degrees) => degrees * DegToTurn;
        public static Vector2 DegreesToUnitVector(double degrees) => Vector2.Normalize(new Vector2((float)Math.Cos(degrees), (float)Math.Sin(degrees)));
        public static List<double> DegreesToList(double degrees) => new List<double>() { Math.Cos(degrees), Math.Sin(degrees) };
        #endregion

        #region Radians convert
        public static double RadiansToDegrees(double radians) => radians * RadToDeg;
        public static double RadiansToGradians(double radians) => radians * RadToGrad;
        public static double RadiansToTurns(double radians) => radians * RadToTurn;
        public static Vector2 RadiansToUnitVector(double radians) => DegreesToUnitVector(RadiansToDegrees(radians));
        public static List<double> RadiansToList(double radians) => DegreesToList(RadiansToDegrees(radians));
        #endregion

        #region Gradians convert
        public static double GradiansToDegrees(double gradians) => gradians * GradToDeg;
        public static double GradiansToRadians(double gradians) => gradians * GradToRad;
        public static double GradiansToTurns(double gradians) => gradians * GradToTurn;
        public static Vector2 GradiansToUnitVector(double radians) => DegreesToUnitVector(GradiansToDegrees(radians));
        public static List<double> GradiansToList(double radians) => DegreesToList(GradiansToDegrees(radians));
        #endregion

        #region Turn convert
        public static double TurnsToDegrees(double turns) => turns * TurnToDeg;
        public static double TurnsToRadians(double turns) => turns * TurnToRad;
        public static double TurnsToGradians(double turns) => turns * TurnToGrad;
        public static Vector2 TurnsToUnitVector(double radians) => DegreesToUnitVector(TurnsToDegrees(radians));
        public static List<double> TurnsToList(double radians) => DegreesToList(TurnsToDegrees(radians));
        #endregion
        
        #region Normalize Angle
        public static double NormalizeDegrees(double degrees)
        {
            while (degrees <= -HalfTurnDeg) degrees += TurnToDeg;
            while (degrees > HalfTurnDeg) degrees -= TurnToDeg;
            return degrees;
        }
        public static double NormalizeRadians(double radians)
        {
            while (radians <= -HalfTurnRad) radians += TurnToRad;
            while (radians > HalfTurnRad) radians -= TurnToRad;
            return radians;
        }
        public static double NormalizeGradians(double gradians)
        {
            while (gradians <= -HalfTurngGrad) gradians += TurnToGrad;
            while (gradians > HalfTurngGrad) gradians -= TurnToGrad;
            return gradians;
        }
        public static double NormalizeTurn(double turns)
        {
            while (turns <= -HalfTurn) turns += 1;
            while (turns > HalfTurn) turns -= 1;
            return turns;
        }
        #endregion


    }
}
