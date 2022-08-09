`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    14:45:34 09/18/2019 
// Design Name: 
// Module Name:    S1063697Lab1 
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
module S1063697Lab1(
    input [7:0] switch,
    output [4:0] led
    );
	
	adder_4bit U0(switch[3:0],switch[7:4],led[3:0],led[4]);
	

endmodule
