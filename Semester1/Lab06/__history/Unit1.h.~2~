//---------------------------------------------------------------------------

#ifndef Unit1H
#define Unit1H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <FMX.Controls.hpp>
#include <FMX.Forms.hpp>
#include <FMX.Forms3D.hpp>
#include <FMX.Ani.hpp>
#include <FMX.Controls3D.hpp>
#include <FMX.MaterialSources.hpp>
#include <FMX.Objects3D.hpp>
#include <FMX.Types.hpp>
#include <System.Math.Vectors.hpp>
#include <FMX.Controls.Presentation.hpp>
#include <FMX.StdCtrls.hpp>
#include <FMX.Types3D.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm3D
{
__published:	// IDE-managed Components
	TSphere *Earth;
	TTextureMaterialSource *EarthTextureAlbedo;
	TFloatAnimation *FloatAnimation1;
	TText3D *Text3D1;
	void __fastcall EarthMouseWheel(TObject *Sender, TShiftState Shift, int WheelDelta,
		  bool &Handled);
	void __fastcall EarthMouseMove(TObject *Sender, TShiftState Shift, float X, float Y,
		  TVector3D &RayPos, TVector3D &RayDir);
	void __fastcall EarthMouseDown(TObject *Sender, TMouseButton Button, TShiftState Shift,
          float X, float Y, TVector3D &RayPos, TVector3D &RayDir);
	void __fastcall EarthMouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
          float X, float Y, TVector3D &RayPos, TVector3D &RayDir);
	void __fastcall Form3DMouseUp(TObject *Sender, TMouseButton Button, TShiftState Shift,
		  float X, float Y);

private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
