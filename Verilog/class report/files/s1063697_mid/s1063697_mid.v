`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    16:12:35 11/15/2019 
// Design Name: 
// Module Name:    s1063697_mid 
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
module s1050689Mid(
		input wire mclk,
		input wire [0:0] btn,
		output wire [0:6] seg, 
		output wire [3:0] an,
		output wire dp,
		output [2:0] led1,
		output [7:5] led2	
	); 
	
traffic_light U1(
	  .clk(mclk),
	  .reset(btn),
	  .a_to_g(seg),
	  .R1_led(led2[7]),
	  .Y1_led(led2[6]),
	  .G1_led(led2[5]),
	  .R2_led(led1[2]),
	  .Y2_led(led1[1]),
	  .G2_led(led1[0]),
	  .an(an),
	  .dp(dp)
   );
endmodule

