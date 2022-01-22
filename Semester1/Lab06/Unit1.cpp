//---------------------------------------------------------------------------

#include <fmx.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.fmx"
TForm1 *Form1;
bool mouseState;
float mouseOldX = 0.0;
float mouseOldY = 0.0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm3D(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::EarthMouseWheel(TObject *Sender, TShiftState Shift, int WheelDelta,
          bool &Handled)
{
//	int pos = Earth->Position->Z;
//	Earth -> AnimateFloat("Position.Z", pos + WheelDelta / 120);
	int scale = Earth->Scale->Z;
	Earth -> AnimateFloat("Scale.X", scale + WheelDelta / 120);
	Earth -> AnimateFloat("Scale.Y", scale + WheelDelta / 120);
	Earth -> AnimateFloat("Scale.Z", scale + WheelDelta / 120);

}
//---------------------------------------------------------------------------

void __fastcall TForm1::EarthMouseMove(TObject *Sender, TShiftState Shift, float X,
		  float Y, TVector3D &RayPos, TVector3D &RayDir)
{

	if (mouseState) {
//		Earth -> AnimateFloat("Position.Y", Y/100);
//		Earth -> AnimateFloat("Position.X", X/100);
		float angleX = Earth -> RotationAngle -> X;
		float angleY = Earth -> RotationAngle -> Y;
//		Earth -> AnimateFloat("RotationAngle.Y", angleX+X);
//		Earth -> AnimateFloat("RotationAngle.X", angleY+Y);

		Earth -> RotationAngle -> X = angleX + (Y - mouseOldY);
		Earth -> RotationAngle -> Y = angleY - (X - mouseOldX);
		Text3D1 -> Text = angleY;
	}

	mouseOldX = X;
	mouseOldY = Y;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::EarthMouseDown(TObject *Sender, TMouseButton Button, TShiftState Shift,
		  float X, float Y, TVector3D &RayPos, TVector3D &RayDir)
{
	mouseState = true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::EarthMouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
          float X, float Y, TVector3D &RayPos, TVector3D &RayDir)
{
	mouseState = false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Form3DMouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
          float X, float Y)
{
	mouseState = false;
}
//---------------------------------------------------------------------------
