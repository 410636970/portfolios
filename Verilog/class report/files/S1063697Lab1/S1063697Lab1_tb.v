`timescale 1ns / 1ps

////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer:
//
// Create Date:   14:56:05 09/18/2019
// Design Name:   S1063697Lab1
// Module Name:   C:/Users/student/Desktop/ooo/S1063697Lab1/S1063697Lab1_tb.v
// Project Name:  S1063697Lab1
// Target Device:  
// Tool versions:  
// Description: 
//
// Verilog Test Fixture created by ISE for module: S1063697Lab1
//
// Dependencies:
// 
// Revision:
// Revision 0.01 - File Created
// Additional Comments:
// 
////////////////////////////////////////////////////////////////////////////////

module S1063697Lab1_tb;

	// Inputs
	reg [7:0] switch;

	// Outputs
	wire [4:0] led;

	// Instantiate the Unit Under Test (UUT)
	S1063697Lab1 uut (
		.switch(switch), 
		.led(led)
	);

	initial begin
		// Initialize Inputs
		switch = 0;

		// Wait 100 ns for global reset to finish
		#100;
        
		// Add stimulus here
			switch = 8'h25;
		#50 switch = 8'h2ab;
		#50 switch = 8'h6c;
		#50 $finish;

	end
      
endmodule

