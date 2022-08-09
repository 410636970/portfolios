`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    16:16:53 11/15/2019 
// Design Name: 
// Module Name:    x7seg 
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
module x7seg(
		input wire [15:0] x,
		input wire clk,
		input wire clr,
		output reg [6:0] a_to_g,
		output reg [3:0] an,
		output wire dp
    );
 wire [1:0] s;
 
 reg [3:0] digit;
 wire [3:0] aen;
 reg [19:0] clkdiv;
 assign dp = 1;
 


// count every __ ms
 assign s= clkdiv[19:18];

 // enable all digits
 assign aen = 4'b1111; 
 
 // Digit select: ancode 
 always@(*) begin 
   an =4'b1111; 
   if (aen[s] ==1) an[s] = 0;
 end
 
 //時脈分頻器(除頻) 
 always @ (posedge clk or posedge  clr)
 begin 
   if(clr==1) clkdiv <= 0; 
   else clkdiv <= clkdiv + 1; 
 end
 
 
 
   

 always@(*) //4位4選1 : mux44
   case (s)
     0: digit = x[3:0];
     1: digit = x[7:4];
     2: digit = x[11:8];
     3: digit = x[15:12];
     default: digit = x[3:0];
	endcase

   // 7段解碼器(hex7seg); 
 always @(*)
   case (digit)
     0: a_to_g = 7'b0000001;
     1: a_to_g = 7'b1001111;
     2: a_to_g = 7'b0010010;
     3: a_to_g = 7'b0000110;
     4: a_to_g = 7'b1001100;
     5: a_to_g = 7'b0100100;
     6: a_to_g = 7'b0100000;
     7: a_to_g = 7'b0001111;
     8: a_to_g = 7'b0000000;
     9: a_to_g = 7'b0000100;
   'ha: a_to_g = 7'b0000010;
   'hb: a_to_g = 7'b1100000;
   'hc: a_to_g = 7'b0110001;
   'hd: a_to_g = 7'b1000010;
   'hE: a_to_g = 7'b0110000;
   'hF: a_to_g = 7'b0111000;
   default: a_to_g =7'b0000001;//0 
   endcase 

endmodule