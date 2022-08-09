`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    17:16:53 10/21/2019 
// Design Name: 
// Module Name:    MUX_4x1 
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
module MUX_4x1(
input a,b,c,d,
input [1:0]select,
output reg result
    );
	 
always @(a,b,c,d,select)
	case(select)
		2'b00 : result = a;
		2'b01 : result = b;
		2'b10 : result = c;
		2'b11 : result = d;
	endcase

endmodule
