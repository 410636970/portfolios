module ALU_MSB(a,b,Ainvert,Binvert,CarryIn,Operation,Less,Result,Overflow,Set);
input a, b, Ainvert, Binvert, CarryIn, Less;
input [1:0] Operation;
output Result, Overflow, Set;

reg Result;
wire ain,bin,andO,orO,sum,CarryOut;


assign ain = (Ainvert)? (~a) : a;
assign bin = (Binvert)? (~b) : b;
assign andO = ain & bin;
assign orO = ain | bin;
assign {CarryOut,sum}=ain+bin+CarryIn;
assign Overflow = CarryOut xor CarryIn;
assign Set = sum;
always @ (andO,orO,sum,Less,Operation)
	case  ({Operation})
		2'b00: Result=andO;
		2'b01: Result=orO;
		2'b10: Result=sum;
		2'b11: Result=Less;
		default: Result=1'bz;
	endcase


endmodule