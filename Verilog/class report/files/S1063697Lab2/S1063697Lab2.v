`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    17:24:33 10/21/2019 
// Design Name: 
// Module Name:    S1063697Lab2 
// Project Name: 
// Target Devices: 
// Tool versions: 
// Description: 
//
// Dependencies: 
//
// Revision: 
// Revision 0.01 - File Created
// Additional Comments: 
//
//////////////////////////////////////////////////////////////////////////////////
module S1063697Lab2(a, b, Less, CarryIn, Ainvert, Binvert, Operation,
Result, CarryOut);
input a, b, Less, CarryIn, Ainvert, Binvert;
input [1:0] Operation;
output Result, CarryOut;
wire ain,bin,andO,orO,sum;

MUX_2x1 MUX1(a, Ainvert, ain);
MUX_2x1 MUX2(b, Binvert, bin);
and andgate(andO, ain, bin);
or orgate(orO, ain, bin);
FA fulladder(ain, bin, CarryIn, sum, CarryOut);
MUX_4x1 MUX3(andO, orO, sum, Less, Operation, Result);

endmodule

