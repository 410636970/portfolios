`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    17:13:29 10/21/2019 
// Design Name: 
// Module Name:    MUX_2x1 
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
module MUX_2x1( // Data flow modeling
input x,
input select,
output z);
	
assign y = ~x;
assign z = (select)? y: x;
	
endmodule
