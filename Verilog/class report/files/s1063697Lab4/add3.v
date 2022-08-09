`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    23:46:42 11/27/2019 
// Design Name: 
// Module Name:    add3 
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
module add3(
   input A3,A2,A1,A0,
	output S3,S2,S1,S0);
	
	assign S3= A3 | A2&A0 | A2&A1;
	assign S2= A3&A0 | A2&(~A1)&(~A0);
	assign S1= A3&(~A0) | A0&A1 | A1&(~A2);
	assign S0= A3&(~A0) | A2&(~A0) | A0&(~A1)&(~A2)&(~A3);
	
endmodule
