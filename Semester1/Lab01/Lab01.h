//---------------------------------------------------------------------------

#ifndef Lab01H
#define Lab01H
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Grids.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TStringGrid *SG1;
	TLabel *Label1;
	TEdit *CollsEdit;
	TLabel *Label2;
	TEdit *RowsEdit;
	TLabel *Out1;
	TButton *Button1;
	TLabel *Label3;
	TLabel *MaxVal;
	TLabel *Label4;
	TLabel *MinVal;
	TLabel *Label5;
	void __fastcall CollsEditChange(TObject *Sender);
	void __fastcall RowsEditChange(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
