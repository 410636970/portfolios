`timescale 1ns / 1ps

////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer:
//
// Create Date:   17:26:00 10/21/2019
// Design Name:   S1063697Lab2
// Module Name:   D:/wei/work/3junior/HDL/ooo2/S1063697Lab2/S1063697Lab2_tb.v
// Project Name:  S1063697Lab2
// Target Device:  
// Tool versions:  
// Description: 
//
// Verilog Test Fixture created by ISE for module: S1063697Lab2
//
// Dependencies:
// 
// Revision:
// Revision 0.01 - File Created
// Additional Comments:
// 
////////////////////////////////////////////////////////////////////////////////

module S1063697Lab2_tb; //´ú¸Õ¼Ò²Õ
reg a,b,Less,CarryIn,Ainvert,Binvert;
reg [1:0] Operation;
wire Result,CarryOut;
S1063697Lab2 U0(a,b,Less,CarryIn,Ainvert,Binvert,Operation,Result,CarryOut);
 
//waveform
initial begin
a=1;b=0;Less=0;CarryIn=0;Ainvert=0;Binvert=0;Operation=0;
#5 Operation=1;
#5 Operation=2;
#5 Operation=3;
#10 a=1;b=1;Binvert=1;Operation=0;
#5 Operation=1;
#5 Operation=2;
#5 Operation=3;
#10 $finish;
end
endmodule

