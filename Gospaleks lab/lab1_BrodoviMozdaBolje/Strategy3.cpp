#include "Strategy3.h"
#include <iostream>
Strategy3::Strategy3(Position fHit, Position sHit)
{
    this->fHit = fHit;
    this->sHit = sHit;
    goLeft = goTop = false;
    misses = 0;
}

Strategy3::~Strategy3()
{
}

Position Strategy3::move()
{
    // Ship is horizontal
    if (fHit.row == sHit.row) {

        if (goLeft)
            return Position(fHit.row, --fHit.col);
        else
            return Position(sHit.row, ++sHit.col);
    }

    // Ship is vertical
    else if (fHit.col == sHit.col) {

        if (goTop)
            return Position(--fHit.row, fHit.col);
        else
            return Position(++sHit.row, sHit.col);

    }
}

// Strategy 3 sunks the ship but this is actually two misses (on both sides of ship)
bool Strategy3::isFinished(bool& isHitted)
{
    if (!isHitted)
        ++misses;

    // If number of misses is 1 go to other side of ship
    if (misses == 1) {
        std::cout << "menjam smer\n";
        goLeft = true;
        goTop = true;
        return false;
    }
    // When number of misses is 2 ship is dead and strategy 3 is finished
    else if (misses == 2) {
        std::cout << "odradio\n";
        return true;
    }
    else 
        return false;
}

