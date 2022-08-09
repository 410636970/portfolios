`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    16:16:05 11/15/2019 
// Design Name: 
// Module Name:    traffic_light 
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
module traffic_light(
		input wire clk,
		input wire reset,
		output wire R1_led, 
		output wire Y1_led,
		output wire G1_led,
		output wire R2_led,
		output wire Y2_led,
		output wire G2_led,
		output wire [6:0] a_to_g ,
		output wire [3:0] an ,
		output wire dp
	);
reg [2:0] currentState,nextState;
reg r1,y1,g1,r2,y2,g2;
assign R1_led = r1 ;
assign Y1_led = y1 ;
assign G1_led = g1 ;
assign R2_led = r2 ;
assign Y2_led = y2 ;
assign G2_led = g2 ;

wire [15:0] x; 
reg [15:0] y;
reg flag;
wire [3:0] cnt;
reg [29:0] clkdiv1;
assign cnt= clkdiv1[29:26];
assign x = y;

x7seg Xl (
	  .x (x),
	  .clk(clk),
	  .clr(reset),
	  .a_to_g(a_to_g),
	  .an(an),
	  .dp(dp)
		 ); 
always@(currentState or cnt or flag) ///燈的狀態
begin
 case(currentState)
	 3'b011:
	 if(cnt==4'b1010)
	 nextState <= 3'b100;
	 else
	 nextState <= 3'b011;
	 
	 3'b100:
	 if(cnt==4'b1100)
	 nextState <= 3'b101;
	 else
	 nextState <= 3'b100;
	 
	 3'b101:
	 if(cnt==4'b1101)
	 nextState <= 3'b110;
	 else
	 nextState <= 3'b101;
	 
	 3'b110:
	 if(cnt==4'b1010)
	 nextState <= 3'b111;
	 else
	 nextState <= 3'b110;
	 
	 3'b111:
	 if(cnt==4'b1100)
	 nextState <= 3'b010;
	 else
	 nextState <= 3'b111;
	 3'b010:
	 if(cnt==4'b1101)
	 nextState <= 3'b011;
	 else
	 nextState <= 3'b010;
	default:begin
					nextState <= 3'b011 ;
			   end
   endcase
	if(flag == 0)
	
		if(cnt>=4'b0100) 
		y = {8'h0,8'hd-cnt};
		else
		y = {8'h0,8'h13-cnt}; 
	
	else
		if(cnt>=4'b0100) 
		y = {8'hd-cnt,8'h0};
		else
		y = {8'h13-cnt,8'h0}; 
end


 //時脈分頻器(除頻) 
 always @ (posedge clk or posedge  reset)//因為f=50百萬下 調慢50百萬 即可變成每秒1下  
 begin 
 
	if (reset==1) 
	begin 
	currentState <= 3'b011 ;
	flag <= 0;
	end
	else currentState <= nextState;
	
   if(reset==1) clkdiv1 <= 0; 
	else if(cnt==4'b1110)begin 
		clkdiv1 <= 0; 
		flag <= ~flag ;
	end
   else clkdiv1 <= clkdiv1 + 1; 
 end

always@(currentState)
begin
        case(currentState)
        3'b010: begin
                  r1=1'b1;
						y1=1'b0;
						g1=1'b0;
						r2=1'b1;
						y2=1'b0;
						g2=1'b0;
                  end

        3'b011: begin
                  r1=1'b0;
						y1=1'b0;
						g1=1'b1;
						r2=1'b1;
						y2=1'b0;
						g2=1'b0;
                  end

        3'b100: begin
                  r1=1'b0;
						y1=1'b1;
						g1=1'b0;
						r2=1'b1;
						y2=1'b0;
						g2=1'b0;
                  end
        3'b101: begin
                   r1=1'b1;
						y1=1'b0;
						g1=1'b0;
						r2=1'b1;
						y2=1'b0;
						g2=1'b0;
                  end
        3'b110: begin
                  r1=1'b1;
						y1=1'b0;
						g1=1'b0;
						r2=1'b0;
						y2=1'b0;
						g2=1'b1;
                  end
        3'b111: begin
                   r1=1'b1;
						y1=1'b0;
						g1=1'b0;
						r2=1'b0;
						y2=1'b1;
						g2=1'b0;
                  end

			default:begin
					r1=1'b0;
					y1=1'b0;
					g1=1'b1;
					r2=1'b1;
					y2=1'b0;
					g2=1'b0;
				  end
        endcase
end

endmodule