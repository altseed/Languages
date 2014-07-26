/*
cpp2ast: make AST from C++ code by clang.

This project is distributed under the University of Illinois Open Source License.

*/
#include <string>
#include <iostream>
#include <clang-c/Index.h>


std::string getSpell(CXCursor const& cur) {
	CXString spell = clang_getCursorSpelling(cur);
	std::string const ret = std::string(clang_getCString(spell));
	clang_disposeString(spell);
	return ret;
}

CXChildVisitResult walkerCallback(CXCursor cursor, CXCursor parent, CXClientData client_data) {

	std::cout << getSpell(cursor) << std::endl;

	return CXChildVisit_Recurse;
}

int main(int argc, char *argv[]) {
	

	auto idx = clang_createIndex(1, 1);
	auto trans = clang_createTranslationUnit(idx, argv[1]);

	if(nullptr == trans) {
		return -1;
	}
	auto cur = clang_getTranslationUnitCursor(trans);
	clang_visitChildren(cur, walkerCallback, nullptr);
	clang_disposeIndex(idx);
	clang_disposeTranslationUnit(trans);
	char c;
	std::cin >>c;

	return 0;
}