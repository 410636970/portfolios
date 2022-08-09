`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    23:30:51 11/27/2019 
// Design Name: 
// Module Name:    s1063697_Lab4 
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
module s1063697_Lab4(
 input wire mclk,
 input wire [1:0] btn,
 input wire [7:0] sw,
 output wire [0:6] Seg,
 output wire [3:0] an,
 output wire dp
 );

 reg [12:0] accumulatedSum;

 wire [15:0] x;
 reg [21:0] clkdiv;
 reg        clk_13Hz;
 
always @ (posedge mclk) begin
  clkdiv <= clkdiv + 1;
  if (clkdiv == 0) clk_13Hz = ~clk_13Hz;
end

always@(posedge clk_13Hz) begin
   if (btn[0] ==1) accumulatedSum = 0;
    if (btn[1] ==1) accumulatedSum = accumulatedSum+sw;
end

x7seg U0(
 .x(x),
 .clk(mclk),
 .clr(btn[0]),
 .a_to_g(Seg),
 .an(an),
 .dp(dp)
 );

Binary2BCD U1(
 .B(accumulatedSum),
 .P(x)
 );
endmodule

