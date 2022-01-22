//---------------------------------------------------------------------------

#ifndef ProcH
#define ProcH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Grids.hpp>
#include <Vcl.Menus.hpp>
//---------------------------------------------------------------------------
class TForm3 : public TForm
{
__published:	// IDE-managed Components
	TLabel *Task_name;
	TStringGrid *SG1;
	TEdit *Rows_edit;
	TEdit *Colls_edit;
	TStringGrid *SG2;
	TButton *Button1;
	TMainMenu *MainMenu1;
	TMenuItem *Processing1;
	TMenuItem *Solve1;
	void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
	void __fastcall Rows_editChange(TObject *Sender);
	void __fastcall Colls_editChange(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm3(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm3 *Form3;
//---------------------------------------------------------------------------
#endif
