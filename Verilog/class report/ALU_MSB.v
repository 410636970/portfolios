module ALU_MSB(a,b,Ainvert,Binvert,CarryIn,Operation,Less,Result,Overflow,Set);
input a, b, Ainvert, Binvert, CarryIn, Less;
input [1:0] Operation;
output Result, Overflow, Set;

reg Result;
wire ain,bin,andO,orO,sum,CarryOut,sub,slt,nor0;


assign ain = (Ainvert)? (~a) : a;
assign bin = (Binvert)? (~b) : b;
assign andO = ain & bin;
assign orO = ain | bin;
assign sub = ain - bin;
assign slt = (ain<bin) ?  1 : 0 ;
assign nor0 = (~ain) & (~bin);
assign {CarryOut,sum}=ain+bin+CarryIn;
xor G1(Overflow,CarryOut,CarryIn);
assign Set = sum;
always @ (andO,orO,sum,Less,Operation)
	case  ({Operation})
		4'b0000: Result=andO;
		4'b0001: Result=orO;
		4'b0010: Result=sum;
		4'b0110: Result=sub;
		4'b0111: Result=slt;
		4'b1100: Result=nor0;
		default: Result=1'bz;
	endcase


endmodule