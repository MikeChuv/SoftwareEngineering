//---------------------------------------------------------------------------

#ifndef TaskH
#define TaskH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Grids.hpp>
//---------------------------------------------------------------------------
class TForm3 : public TForm
{
__published:	// IDE-managed Components
	TStringGrid *SG1;
	TEdit *Rows_edit;
	TEdit *Colls_edit;
	TLabel *Label1;
	TButton *Button1;
	TStringGrid *SG2;
	TLabel *Task_name;
	void __fastcall Rows_editChange(TObject *Sender);
	void __fastcall Colls_editChange(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
private:	// User declarations
public:		// User declarations
	__fastcall TForm3(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm3 *Form3;
//---------------------------------------------------------------------------
#endif
